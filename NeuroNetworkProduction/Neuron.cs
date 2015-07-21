using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkProduction
{
    class Neuron
    {
        object value; // Выходное значение нейрона.
        List<object> inputs; // Входные значения нейрона
        List<float> weights; // Веса связей нейрона калибруются в диапазоне вещественных значений.
        int type; // Нейроны могут быть входными, выходными и скрытыми разного уровня вложенности отсчитывая от входных к выходным.

        Neuron(List<float> w = null, int t = 0, object v = null) // Конструктор нейронов.
        {
            this.value = v;
            this.type = t;
            if (w.Count != 0) this.weights = w;
            else this.weights.Add(0);
        }

        public static Neuron createNeuron(List<float> w = null, int t = 0, object v = null) // Конструктор нейронов.
        {
            Neuron neuron = new Neuron(w, t, v);
            return neuron;
        }
        
        // Установка значений полей.

        public void setWeight(float w) 
        {
            //this.weight = w;
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
