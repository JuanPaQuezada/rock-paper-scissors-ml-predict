namespace RockPaperScissors.Core.Inference;

public static class EpsilonPolicy
{
    public static double Calculate(int observedCount, int threshold = 10, double epsilonMin = 0.1) {
        double epsilon;

        /*We are going to declare an dynamic epsiilon policy, every time the player take a decision our machine will be prepared
         *For a counter move, since in the start we dont have enough data we will declare our exploration rate to be 1.
         *Then while we save information we will declaro epsilon to 0.1 or near that so that our machine can continue overwrite the vector.*/
        if (1 - ((double)observedCount / threshold) < epsilonMin)
        {
            epsilon = epsilonMin;
        }
        else
        {
            epsilon = 1 - ((double)observedCount / threshold);
        }

        return epsilon;
    }

}