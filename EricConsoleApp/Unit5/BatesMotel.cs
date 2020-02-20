using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit5
{
    public class BatesMotel
    {
        public const int MAXN_ROOMS = 20;

        public const int MAXN_GUESTS = 4;

        private int[] rooms = new int[MAXN_ROOMS + 1];

        public bool Book(int roomNo, int noGuests)
        {
            if (roomNo >= 1 && roomNo <= 20)
            {
                if (noGuests >= 1 && noGuests <= MAXN_GUESTS)
                {
                    rooms[roomNo] = noGuests;
                    return true;
                }
            }

            return false;
        }
    }
}
