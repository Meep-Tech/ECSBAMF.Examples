using System;
using System.Collections.Generic;
using System.Text;

namespace Meep.Tech.Data.Examples.ModelWithComponents {

  public class MiniBuiltCapacitor : FluxCapacitor {

    [Branch]
    public new class Type : FluxCapacitor.Type {

      protected override IReadOnlyDictionary<string, IComponent> InitialComponents
        => base.InitialComponents
          .Append(Components<InfoComponent>.BuilderFactory.Make((nameof(InfoComponent.DefaultText), "Default Info")));

      protected Type() 
        : base(new(nameof(MiniBuiltCapacitor))) { }
    }
  }
}