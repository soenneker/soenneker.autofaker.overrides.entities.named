[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entities.named/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Entities.Named

An AutoFaker override that assigns an ID and display name to `NamedEntity` models.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Entities.Named
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Entities.Named;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new NamedEntityOverride()];

ProductEntity entity = autoFaker.Generate<ProductEntity>();
```

The override applies to `NamedEntity` and derived types. `Id` becomes a GUID string and `Name` becomes a generated commerce product name. Later matching overrides can replace either value.
