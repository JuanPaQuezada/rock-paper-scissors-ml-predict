@@
 ### RESEARCH ML WITH VECTOR
 ## Architectural Research & Concurrency Rationale
 
 The architecture of this simulated Reinforcement Learning environment is heavily anchored in the Task Parallel Library (TPL) and its Dataflow components. By utilizing TPL Dataflow, the system establishes a safe, non-blocking pipeline for state ingestion, feature transformation, inference, and training updates.
 
 Implementing this level of continuous concurrency introduces the critical challenge of shared memory management. In this system, the training pipeline continuously updates the mathematical weights of the model while the UI remains responsive. To guarantee correctness, shared mutable state is protected with synchronization primitives such as `ReaderWriterLockSlim`, ensuring that historical vectors and transition statistics can be read and updated safely.
 
 Furthermore, the design consciously avoids the performance degradation associated with over-parallelization. While the TPL provides powerful abstractions like `Parallel.For` for data parallelism, applying unnecessary parallelism to a small, sequential decision loop would introduce scheduling overhead without measurable benefit. For that reason, the architecture reserves parallel execution for independent, high-cost tasks and keeps the core prediction loop deterministic and lightweight.
 
 Finally, this strict concurrent separation dictates the absolute boundaries of how background processes interact with the presentation layer. A fundamental constraint of multithreaded design is that background workers must never directly mutate UI controls; instead, they publish results through safe marshaling or message-passing mechanisms, allowing the UI thread to remain the sole owner of presentation state.
 
+## Hybrid Flow: C# as System of Record, R as Statistical Oracle
+
+From a data science and research perspective, the cleanest architecture is a **hybrid pipeline with strict ownership boundaries**:
+
+1. **C# stores the authoritative history**
+   - The application keeps the move history and vectorized state in memory.
+   - The sequence may look like `["P", "P", "T", "R", ...]`.
+   - Access to this state is protected with `ReaderWriterLockSlim` or an equivalent synchronization strategy.
+
+2. **C# delegates only the statistical query**
+   - When the system needs to estimate the user's next move, C# packages the current history and sends it to R.
+   - The transfer can happen through R.NET, a lightweight script bridge, or another controlled interop layer.
+   - C# does **not** hand over ownership of the game state; it only requests a prediction.
+
+3. **R performs the Markov-chain estimation**
+   - R receives the array and uses the `markovchain` package to compute the transition matrix and MLE-based estimates.
+   - R acts as a specialized statistical engine, returning a single compact result such as:
+     - `El usuario probablemente jugará Piedra.`
+   - R should remain stateless with respect to the game session whenever possible.
+
+4. **C# regains control immediately**
+   - The inference engine in C# receives the predicted user move and selects the counter-move.
+   - The training engine then updates the vector, computes the TD error, and refreshes the internal state.
+   - The UI is updated from C# only, preserving a strict separation between computation and presentation.
+
+5. **R is disposable between queries**
+   - R may terminate after returning the result, or stay warm for the next request.
+   - In either case, the system must not depend on R retaining memory of previous games.
+
+### Why this flow is correct
+
+This architecture is preferable because it:
+
+- Keeps **C# as the single source of truth** for gameplay state.
+- Uses R only for the part where it provides the highest value: **statistical estimation**.
+- Avoids duplicated state across processes.
+- Reduces coupling between the game loop and the analytical engine.
+- Preserves responsiveness in the UI and predictability in the training pipeline.
+
+### Flow summary
+
+**C# stores history → C# delegates prediction → R computes DTMC/MLE → C# chooses action → C# updates training and UI**
+
+This is the correct boundary for the hybrid model: C# owns orchestration, R owns the statistical calculation, and neither component violates the responsibilities of the other.
+
 ## Discrete-Time Markov Chain (DTMC) Heuristic Baseline
 
