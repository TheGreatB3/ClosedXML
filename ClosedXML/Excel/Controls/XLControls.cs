using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClosedXML.Excel.Controls {
    internal class XLControls : IXLControls, IEnumerable<IXLControl> {
        private readonly List<XLControl> _controls = new List<XLControl>();
        public IEnumerator<IXLControl> GetEnumerator() {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
