
namespace OOP.Models
{
    internal class Calculator
    {
        private int _NumA;
        private int _NumB;
        private int _NumC;
        private int _NumD;

        public Calculator( int NumA, int NumB, int NumC, int NumD)
        {
            _NumA = NumA;
            _NumB = NumB;
            _NumC = NumC;
            _NumD = NumD;
        }

        public void Add(out int Result)
        {
            Result = _NumA + _NumB + _NumC + _NumD;
        }

        public void Subtract(out int Result)
        {
            Result = _NumA - _NumB -_NumC - _NumD;
        }

        public void Multiply(out int Result)
        {
            Result = _NumA * _NumB * _NumC * _NumD;
        }

        public bool Division(out int Result)
        {
            if (_NumB == 0 || _NumC == 0 || _NumD == 0)
            {
                Result = 0;
                return false;
            }

            Result = _NumA / _NumB / _NumC /_NumD;
            return true;
        }
    }
}
