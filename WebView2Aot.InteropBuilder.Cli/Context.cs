using DirectN;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace WebView2Aot.InteropBuilder.Cli;

public class Context(BuilderConfiguration configuration, IGenerator generator)
    : BuilderContext(configuration, generator)
{
    public override SignatureTypeProvider CreateSignatureTypeProvider() => new Stp(this);

    private sealed class Stp(Context context) : SignatureTypeProvider(context)
    {
        public override BuilderType GetTypeFromFullName(FullName fullName)
        {
            BuilderType addType(BuilderType bt)
            {
                Context.AllTypes[bt.FullName] = bt;
                Context.MappedTypes[bt.FullName] = bt;
                return bt;
            }

            if (fullName.ToString() == "Windows.Win32.System.WinRT.EventRegistrationToken")
            {
                var st = new StructureType(new FullName(Builder.Namespace + "." + fullName.Name));
                return addType(st);
            }

            var fn = new FullName("DirectN." + fullName.Name);
            var type = typeof(BOOL).Assembly.GetType(fn.ToString());
            if (type != null)
            {
                var bt = new BuilderType(fn);

                if (fullName == FullName.HRESULT)
                {
                    bt.UnmanagedType = UnmanagedType.Error;
                }

                return addType(bt);
            }

            return base.GetTypeFromFullName(fullName);
        }
    }
}
