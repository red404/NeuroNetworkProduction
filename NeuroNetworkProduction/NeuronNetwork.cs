using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkProduction
{
    class NeuronNetwork
    {
        List<Neuron> neurons;

        // dimentions - кол-во слоёв; neuronArray - готовый набор нейронов.
        public NeuronNetwork(int dimentions = 2, params Neuron[] neuronArray)
        {
            neurons = new List<Neuron>();
            if (neuronArray != null)
            {
                foreach (Neuron neuron in neuronArray)
                { neurons.Add(neuron); }
            }
            else this.neurons = NeuronNetwork.generateNetwork(dimentions);
        }


        static List<Neuron> generateNetwork(int d) // Генерирование набора нейронов
        {
            List<Neuron> neurons = new List<Neuron>();
            for(int i = 0; i<d; i++) // Слои
            {
                // Здесь необходим диалог с программой/пользователем, с запросом данных для генерации сети.
                neurons.Add(Neuron.createNeuron());
            }
            return neurons;
        }

        public static void correctWeight(NeuronNetwork NN)
        {
            foreach(Neuron n in NN.neurons)
            {
                n.setWeight(0); // Здесь присваивается обработанное по выбранному закону новое значение веса связи.
            }
        }
    }
}
