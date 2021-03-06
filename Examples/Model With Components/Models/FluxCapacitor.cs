namespace Meep.Tech.Data.Examples.ModelWithComponents {

  /// <summary>
  /// Device base archetype
  /// </summary>
  public partial class FluxCapacitor : Device {

    public int FluxLevel {
      get;
      private set;
    }

    protected FluxCapacitor() 
      : base() {}
  }
}
