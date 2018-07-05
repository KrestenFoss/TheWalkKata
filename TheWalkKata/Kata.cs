
namespace TheWalkKata
{
    /// <summary>
    /// Code-kata: The walk
    /// You can walk in 4 directions: N, S, E, W
    /// Each step takes 1 minute and you have 10 minutes and must return at the same place where you started.
    /// You get a route and must determine if the route is valid (10 steps and at the starting position)
    /// </summary>
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            int upDown = 0;
            int leftRight = 0;

            foreach (var currentStep in walk)
            {
                switch (currentStep.ToLower())
                {
                    case "n": upDown++;
                        break;
                    case "s":
                        upDown--;
                        break;
                    case "w":
                        leftRight--;
                        break;
                    case "e":
                        leftRight++;
                        break;
                    default:
                        return false;
                }
            }

            if (upDown == 0 && leftRight == 0)
                return true;

            return false;
        }
    }
}