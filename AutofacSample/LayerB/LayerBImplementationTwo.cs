using AutofacSample.LayerC;

namespace AutofacSample.LayerB
{
    public class LayerBImplementationTwo : ILayerB
    {
        private ILayerC _layerThree;

        public LayerBImplementationTwo(ILayerC layerThree)
        {
            _layerThree = layerThree;
        }

        public string Name => $"B2\n\t(LayerThreeName: {_layerThree.Name})";
    }
}
