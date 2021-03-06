using static Meep.Tech.Data.Configuration.Loader.Settings;

namespace Meep.Tech.Data.Examples.UnloadableArchetypes {
  [DoNotBuildInInitialLoad]
  public class BeefJerkey : LoadableItem.Type {

    public new static Identity Id {
      get;
    } = new Identity("Beef Jerkey");

    public BeefJerkey() 
      : base(Id) {}
  }
}
