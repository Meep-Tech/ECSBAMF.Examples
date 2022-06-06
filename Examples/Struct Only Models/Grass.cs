using Meep.Tech.Data;

namespace Meep.Tech.Data.Examples.StructOnlyModels {

  /// <summary>
  /// Grass tile
  /// </summary>
  public class Grass : Tile.Type {

    public new static Identity Id {
      get;
    } = new Identity("Grass");

    Grass() 
      : base(Id) {}
  }
}
