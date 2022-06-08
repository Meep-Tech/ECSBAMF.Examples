using Meep.Tech.Data;
using Meep.Tech.Data.Examples.Enumerations;
using System.Linq;
using static Meep.Tech.Data.Configuration.Loader.Settings;

namespace Meep.Tech.Data.Examples.SplayedArchetype {

  /// <summary>
  /// The Base Model for all Stickers
  /// </summary>
  public class Sticker : Model<Sticker, Sticker.Type>, IModel.IUseDefaultUniverse {

    /// <summary>
    /// The Base Archetype for Stickers
    /// </summary>
    [DoNotBuildInInitialLoad]
    public class Type 
      : Archetype<Sticker, Sticker.Type>,
        Archetype.IBuildOneForEach<FruitType, Type>,
        Archetype.IBuildOneForEach<TreeType, Type>
    {

      /// <summary>
      /// Used to make new Child Archetypes for Sticker.Type 
      /// </summary>
      /// <param name="id">The unique identity of the Child Archetype</param>
      protected Type(Identity id)
        : base(id) { }

      FruitType IBuildOneForEach<FruitType, Type>.AssociatedEnum {
        get => _enum as FruitType;
        set => _enum = value;
      }

      TreeType IBuildOneForEach<TreeType, Type>.AssociatedEnum { 
        get => _enum as TreeType;
        set => _enum = value;
      } Enumeration _enum;

      Type IBuildOneForEach<FruitType, Type>.ConstructArchetypeFor(FruitType enumeration) {
        return new Type(
          new Identity(enumeration.ExternalId.ToString().Split('.').Last(),
          keyOverride: enumeration.ExternalId.ToString())
        ) {
          _enum = enumeration
        };
      }

      Type IBuildOneForEach<TreeType, Type>.ConstructArchetypeFor(TreeType enumeration) {
        return new Type(
          new Identity(enumeration.ExternalId.ToString().Split('.').Last(),
          keyOverride: enumeration.ExternalId.ToString())
        ) {
          _enum = enumeration
        };
      }
    }
  }
}
