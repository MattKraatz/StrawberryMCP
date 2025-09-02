# StrawberryMCP

StrawberryMCP is a .NET 10.0 console application that implements a Model Context Protocol (MCP) server with custom tools. It leverages the MCP C# SDK to create a simple example MCP server.

**Custom Tools**:
	- `Echo`: Echoes a message back to the client.
	- `CountCharactersInString`: Counts the number of times a specified character appears in a string, case-insensitive.

## Getting Started

### Prerequisites
- [.NET 10.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)

### Build
```powershell
dotnet build
```

### Run
```powershell
dotnet run
```

## Project Structure

- `Program.cs`: Entry point, configures and runs the MCP server.
- `StrawberryTool.cs`: Contains custom MCP tools.

## More Resources

- [Function calling - OpenAI](https://platform.openai.com/docs/guides/function-calling)
- [Introduction - Model Context Protocol](https://modelcontextprotocol.io/docs/getting-started/intro)
- [Build a Model Context Protocol (MCP) server in C#](https://devblogs.microsoft.com/dotnet/build-a-model-context-protocol-mcp-server-in-csharp/)
- [Model Context Protocol servers](https://github.com/modelcontextprotocol/servers)
- [Create a minimal MCP server using C# and publish to NuGet](https://learn.microsoft.com/en-us/dotnet/ai/quickstarts/build-mcp-server)
- [Authorization - Model Context Protocol](https://modelcontextprotocol.io/specification/2025-06-18/basic/authorization)
- [Building Effective AI Agents - Anthropic](https://www.anthropic.com/engineering/building-effective-agents)
- [YouTube - Jo Van Eyck](https://www.youtube.com/@JoVanEyck)

---
This project is intended as a template or starting point for building MCP servers with custom tools in .NET.
