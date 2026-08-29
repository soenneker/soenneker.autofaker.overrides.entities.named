[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entities.named/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Entities.Named

An AutoFaker (AutoBogus) override for NamedEntity object.

## Install

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Entities.Named
```

## What you get

- `NamedEntityOverride` — An AutoFaker (AutoBogus) override for NamedEntity object.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `NamedEntityOverride.CanOverride(context)` | Executes the can override operation. | A value indicating whether the operation succeeded. |
