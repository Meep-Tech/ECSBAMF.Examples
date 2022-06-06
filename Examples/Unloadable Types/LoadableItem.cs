using Meep.Tech.Data.Configuration;
using Meep.Tech.Data.Examples.ModelWithArchetypes;

namespace Meep.Tech.Data.Examples.UnloadableArchetypes {

  /// <summary>
  /// The Base Model for all LoadableItems
  /// </summary>
  public class LoadableItem : Item {

    /// <summary>
    /// The Base Archetype for LoadableItems
    /// </summary>
    [Branch]
    public new abstract class Type : Item.Type {

      protected override bool AllowInitializationsAfterLoaderFinalization 
        => true;

      /// <summary>
      /// Used to make new Child Archetypes for LoadableItem.Type 
      /// </summary>
      /// <param name="id">The unique identity of the Child Archetype</param>
      protected Type(Identity id)
        : base(id) { }

      public void Unload()
        => TryToUnload();
    }
  }
}
