using AutofacSample.LayerC;
using AutofacSample.LayerB;

namespace AutofacSample.LayerA
{
    public class LayerAImplementationOne : ILayerA
    {
        private ILayerC _layerThree;
        private ILayerB _layerTwo;

        public LayerAImplementationOne(ILayerB layerTwo, ILayerC layerThree)
        {
            _layerTwo = layerTwo;
            _layerThree = layerThree;            
        }

        public string Name => $"A1\n(LayerTwoName: {_layerTwo.Name}\nLayerThreeName: {_layerThree.Name})";
    }
}
