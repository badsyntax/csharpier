This extension adds support for [CSharpier](https://github.com/belav/csharpier), an opinionated code formatter for c#.
It uses Roslyn to parse your code and re-prints it using its own rules.
The printing process was ported from [prettier](https://prettier.io/) but has evolved over time.

To use it:
- Install csharpier globally with `dotnet tool install -g csharpier`
- Use the `Reformat with CSharpier` right click context menu action.
- Optionally configure a keyboard shortcut for `EditorContextMenus.CodeWindow.ReformatWithCSharpier`
- Optionally configure `Reformat with CSharpier on Save` under Tools | Options | CSharpier | General

Please report any [issues](https://github.com/belav/csharpier/issues)