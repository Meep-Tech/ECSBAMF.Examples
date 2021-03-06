using System;

namespace Meep.Tech.Data.Examples.ModelWithComponents {
  public partial class ModularFluxCapacitor {

    /// <summary>
    /// Device base archetype
    /// </summary>
    public new class Type : FluxCapacitor.Type {

      protected override Func<IBuilder<Device>, Device> ModelConstructor
        => builder => new ModularFluxCapacitor();

      protected Type()
        : base(new Identity("Unsafe Modular Flux Capacitor")) { }
    }
  }
}
