using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManager
{
    public class Property
    {
        public string RealValue { get; set; }
        public string ViewValue { get; set; }

        /// <summary>
        /// 프로퍼티 값을 정의 합니다.
        /// </summary>
        /// <param name="Real">실제로 properties파일에 저장될 값입니다.</param>
        /// <param name="View">보여질 값입니다.</param>
        public Property(string Real, string View)
        {
            RealValue = Real;
            ViewValue = View;
        }
    }
}
