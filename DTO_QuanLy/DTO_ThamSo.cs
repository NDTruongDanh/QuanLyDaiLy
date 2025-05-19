using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThamSo
    {
        private string _tenThamSo;
        private int _giaTri;

        public string TenThamSo
        {
            get { return _tenThamSo; }
            set { _tenThamSo = value; }
        }

        public int GiaTri
        {
            get { return _giaTri; }
            set { _giaTri = value; }
        }

        public DTO_ThamSo() { }

        public DTO_ThamSo(string tenThamSo, int giaTri)
        {
            TenThamSo = tenThamSo;
            GiaTri = giaTri;
        }
    }
}
