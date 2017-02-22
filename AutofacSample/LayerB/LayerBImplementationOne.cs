using AutofacSample.LayerC;

namespace AutofacSample.LayerB
{
    public class LayerBImplementationOne : ILayerB
    {
        private ILayerC _layerThree;

        public LayerBImplementationOne(ILayerC layerThree)
        {
            _layerThree = layerThree;
        }

        public string Name => $"B1\n\t(LayerThreeName: {_layerThree.Name})";
    }
}
