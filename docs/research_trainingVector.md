### RESEARCH ML WITH VECTOR

## Architectural Research & Concurrency Rationale

The architecture of this simulated Reinforcement Learning environment is heavily anchored in the Task Parallel Library (TPL) and its Dataflow components. By utilizing TPL Dataflow, the system establishes a safe, non-blocking pipeline for state ingestion, feature transformation, inference, and training updates.

Implementing this level of continuous concurrency introduces the critical challenge of shared memory management. In this system, the training pipeline continuously updates the mathematical weights of the model while the UI remains responsive. To guarantee correctness, shared mutable state is protected with synchronization primitives such as `ReaderWriterLockSlim`, ensuring that historical vectors and transition statistics can be read and updated safely.

Furthermore, the design consciously avoids the performance degradation associated with over-parallelization. While the TPL provides powerful abstractions like `Parallel.For` for data parallelism, applying unnecessary parallelism to a small, sequential decision loop would introduce scheduling overhead without measurable benefit. For that reason, the architecture reserves parallel execution for independent, high-cost tasks and keeps the core prediction loop deterministic and lightweight.

Finally, this strict concurrent separation dictates the absolute boundaries of how background processes interact with the presentation layer. A fundamental constraint of multithreaded design is that background workers must never directly mutate UI controls; instead, they publish results through safe marshaling or message-passing mechanisms, allowing the UI thread to remain the sole owner of presentation state.

## Discrete-Time Markov Chain (DTMC) Heuristic Baseline
