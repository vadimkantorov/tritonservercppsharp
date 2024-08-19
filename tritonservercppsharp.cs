using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
namespace CppSharpTransformer { class DllDemoGenerator : ILibrary {
    public static void Main(string[] args) { ConsoleDriver.Run(new DllDemoGenerator()); }
    public void SetupPasses(Driver driver) { }
    public void Preprocess(Driver driver, ASTContext ctx) { }
    public void Postprocess(Driver driver, ASTContext ctx) { }
    void ILibrary.Setup(Driver driver) { }
    void Setup(Driver driver) {
        var options = driver.Options;
        options.GeneratorKind = GeneratorKind.CSharp;
        var module = options.AddModule("TritonServer");
        module.IncludeDirs.Add("core/include");
        module.Headers.Add("triton/core/tritonserver.h");
        //module.LibraryDirs.Add("/path/to/triton/server.so");
        //module.Libraries.Add("tritonserver.so");
    }
} }
