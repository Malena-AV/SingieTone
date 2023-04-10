using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingieTone
{
    // паттерн гарантирует наличие только одного экземпляра
    class SingleTone
    {
        private static SingleTone single;

        // приватный конструктор - закрываем доступ для создания экземпляров
        private SingleTone() {}

        public static SingleTone GetExample()
        {
            if (single == null)
            {
                single = new SingleTone();
            }
            return single;
        }
    }
}
