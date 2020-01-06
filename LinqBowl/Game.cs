using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBowl
{
    public class Game
    {
        public static int ScoreGame(List<int> game)
        {
            var oddNumberIndexes = Enumerable.Range(0, game.Count -1).Where(i => (i % 2 == 0));

            return oddNumberIndexes.Select(index => ScoreFrame(index, game))
                .Sum();
        }

        static int ScoreFrame(int index, List<int> game)
        {
            if (game[index] == 10)
            {
                return ScoreStrike(index, game);
            }
            else if (game.GetRange(index, 2).Sum() == 10)
            {
                return ScoreSpare(index, game);
            }
            else
            {
                return game.GetRange(index, 2).Sum();
            }
        }

        static int ScoreStrike(int index, List<int> game)
        {
            return game.GetRange(index, 3).Sum();
        }

        static int ScoreSpare(int index, List<int> game)
        {
            return game[index + 3] + 10;
        }
    }
}
