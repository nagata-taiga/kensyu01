using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0501 {
    class Program {
        static void Main(string[] args) {
            Examination examination1 = new Examination("山田太郎");

            Examination examination2 = new Examination("浜田南",80);

            examination1.Judge();

            examination2.Judge();
        }
    }
}
