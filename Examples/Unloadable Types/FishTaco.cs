namespace Meep.Tech.Data.Examples.UnloadableArchetypes {
  public class FishTaco : LoadableItem.Type {

    public new static Identity Id {
      get;
    } = new Identity("Fish Taco");

    internal FishTaco() 
      : base(Id) {}
  }
}
