using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkProduction
{
    class Neuron
    {
        object value; // Выходное нейрона.
        float weight; // Веса нейрона калибруются в диапазоне вещественных значений.
        int type; // Нейроны могут быть входными, выходными и скрытыми разного уровня вложенности отсчитывая от входных к выходным.

        Neuron(int t = 0, float w = 0, object v = null) // Конструктор нейронов.
        {
            this.value = v;
            this.type = t;
            this.weight = w;
        }

        public static Neuron createNeuron(int t = 0, float w = 0, object v = null) // Конструктор нейронов.
        {
            Neuron neuron = new Neuron(t, w, v);
            return neuron;
        }
        
        // Установка значений полей.

        public void setWeight(float w) 
        {
            this.weight = w;
        }

        public void setType(int t)
        {
            this.type = t;
        }

        public void setValue(object v)
        {
            this.value = v;
        }
    }
}
