using AutofacSample.LayerC;
using AutofacSample.LayerB;

namespace AutofacSample.LayerA
{
    public class LayerAImplementationTwo : ILayerA
    {
        private ILayerC _layerThree;
        private ILayerB _layerTwo;

        public LayerAImplementationTwo(ILayerB layerTwo, ILayerC layerThree)
        {
            _layerTwo = layerTwo;
            _layerThree = layerThree;
        }

        public string Name => $"A2\n(LayerTwoName: {_layerTwo.Name}\nLayerThreeName: {_layerThree.Name})";
    }
}
