using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintOmittedTypeArgumentSyntax(
            OmittedTypeArgumentSyntax node)
        {
            return Doc.Null;
        }
    }
}
