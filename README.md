# 1808-uha-repo3

## How to use the IDocument Interface
```csharp
using SingleDocumentInterface.Documents;

IDocument loader = new Drivers.FileSystemDocument();
IDocument document = loader.Load("path\to\your\file");

// Do any operation needed with "document"

document.Save("path\to\your\file");
```
