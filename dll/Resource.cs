using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.libcraft.unusualkitchen;
public class Resource
{
    public ResourceDef Def { get; private set; }
    public string Name => Def.Name;
    public string IconPath => Def.IconPath;
    public float Quantity { get; set; }
}
