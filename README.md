# SharpTL.Compiler

Compiles a TL-schema defined in [Type Language] (or JSON equivalent) to C# object model.

Usage example:
```powershell
SharpTL.Compiler.CLI.exe compile -t json -s telegram.json -ns SharpTelegram.Schema -mn Telegram -impl
```
This command produces 2 files:
- `SharpTelegram.Schema.cs` schema types and methods interfaces.
- `SharpTelegram.Schema.MethodsImpl.cs` schema methods implementation (generated only with `-impl` arg). In order to compile this file, [SharpMTProto] library must be referenced.

[SharpTL]: https://github.com/Taggersoft/SharpTL
[SharpMTProto]: https://github.com/Taggersoft/SharpMTProto
[Type Language]: http://core.telegram.org/mtproto/TL
