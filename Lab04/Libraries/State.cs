using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Libraries
{
    public class State
    {
        public int LeftM;
        public int RightM;
        public int LeftC;
        public int RightC;
        public bool Boat; // False is in left,   True is in right
        public State Parent;
        public List<State> Childs;
        public bool IsVisited;

        public State(int leftM, int rightM, int leftC, int rightC, bool boat)
        {
            LeftM = leftM;
            RightM = rightM;
            LeftC = leftC;
            RightC = rightC;
            Boat = boat;
            Parent = null;
            Childs = new List<State>();
            IsVisited = false;
        }

        public void GenerateChilds()
        {
            if (!Boat) //boat is in left side
            {
                State child = new State(LeftM - 1, RightM + 1, LeftC, RightC, true); // 1M from left to right.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

                child = new State(LeftM - 2, RightM + 2, LeftC, RightC, true); // 2M from left to right.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

                child = new State(LeftM - 1, RightM + 1, LeftC - 1, RightC + 1, true); // 1M and 1C from left to right.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

                child = new State(LeftM, RightM, LeftC - 2, RightC + 2, true); // 2C from left to right.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }
            }

            else //boat is in right side
            {
                State child = new State(LeftM + 1, RightM - 1, LeftC, RightC, false); // 1M from right to left.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

                child = new State(LeftM + 2, RightM - 2, LeftC, RightC, false); // 2M from right to left.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

                child = new State(LeftM + 1, RightM - 1, LeftC + 1, RightC + 1, false); // 1M and 1C from right to left.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

                child = new State(LeftM, RightM, LeftC + 2, RightC - 2, false); // 2C from right to left.
                if (IsValid(child))
                {
                    Childs.Add(child);
                }

            }
        }

        public bool IsValid(State state)
        {
            if((LeftM >= 0 && LeftC >= 0 && RightC >= 0 && RightM >= 0) &&
                (LeftM <= 3 && LeftC <= 3 && RightC <= 3 && RightM <= 3) &&
                (LeftM == 0 || LeftM >= LeftC) &&
                (RightM == 0 || RightM >= RightC) 
                ) return true;
            return false;
        }

        public bool IsFinal()
        {
            if (LeftC == 0 && LeftM == 0) return true;
            return false;
        }





    }
}
