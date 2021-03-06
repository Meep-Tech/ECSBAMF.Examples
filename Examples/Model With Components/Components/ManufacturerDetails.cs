using System;

namespace Meep.Tech.Data.Examples.ModelWithComponents {
  public partial struct ManufacturerDetails
    : IModel.IComponent<ManufacturerDetails>,
      IModel.IComponent.IIsRestrictedTo<Device>,
      IComponent.IUseDefaultUniverse
  {

    static void Setup(Universe universe) 
      => universe
        .Components
          .SetBuilderFactoryFor
            <ManufacturerDetails>
              (new BuilderFactory());

    public string ManufacturerName {
      get;
      private set;
    }

    public DateTime? ManufactureDate {
      get;
      private set;
    }

    public int QuantityProduced {
      get;
      private set;
    }
  }
}
