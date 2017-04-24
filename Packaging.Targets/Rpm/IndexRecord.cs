﻿namespace Packaging.Targets.Rpm
{
    internal struct IndexRecord
    {
        /// <summary>
        /// Value identifying the purpose of the data associated with this Index Record.
        /// The value of this field is dependent on the context in which the Index Record is used.
        /// </summary>
        public IndexTag Tag;

        /// <summary>
        /// Value identifying the type of the data associated with this Index Record.
        /// </summary>
        public IndexType Type;

        /// <summary>
        /// Location in the Store of the data associated with this Index Record. This value should between 0 and the value contained 
        /// in <see cref="RpmHeader.Size"/>.
        /// </summary>
        public uint Offset;

        /// <summary>
        /// Size of the data associated with this Index Record. The count is the number of elements whose size is defined by the type of this Record.
        /// </summary>
        public uint Count;

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Tag.ToString();
        }
    }
}
