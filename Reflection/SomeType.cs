using System;

namespace Reflection
{
    // This class is used to demonstrate reflection
    // It has a field, constructor, method, property, and an event
    internal sealed class SomeType
    {
        private int m_someField;
        public SomeType(ref int x) { x *= 2; }
        public override string ToString() { return m_someField.ToString(); }
        public int SomeProp
        {
            get { return m_someField; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(value));
                m_someField = value;
            }
        }
        public event EventHandler SomeEvent;
        private void NoCompilerWarnings() { SomeEvent.ToString(); }
    }
}
