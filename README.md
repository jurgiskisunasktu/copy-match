# CopyMatch

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

> Component for data transfers between different classes with same parameters and different naming conventions availability.

---

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [License](#license)

---

## Installation

Installing package is available in NuGet.

Package manager installation

```powershell
Install-Package CopyMatch -Version 1.0.0
```

.NET CLI installation

```powershell
dotnet add package CopyMatch --version 1.0.0
```

## Usage

Import CopyMatch into needed file:
```c#
using CopyMatch;
```
Same action can be achieved in two ways. So After loading some data

```c#
// Initialize some data
DummyA dummyA = new DummyA();
dummyA.LoadDefaults();

// Create an object of different class to copy to
DummyB dummyB = new DummyB();
```

We can transfer the data by using a method:

```c#
Copier copier = new Copier();
copier.Copy(camelCaseDummyA, camelCaseDummyB);
```

or by using a helper:

```c#
dummyB.CopyToOtherClass(dummyA);
```

## Configuration

If default configuration does not fit your needs, you are able to change some parameters. Be aware that the best place to configure the package is before usage, witch is usually at app start.

These are the available options that you can change. Currently shown values are the defaults.

```c#
CopierSettings.Instance.CamelCaseToSnakeCaseConvertionEnabled = true;
CopierSettings.Instance.CamelCaseToKebabCaseConvertionEnabled = true;
CopierSettings.Instance.SnakeCaseToCamelCaseConvertionEnabled = true;
CopierSettings.Instance.SnakeCaseToKebabCaseConvertionEnabled = true;
```

---

## License

- **[MIT license](https://opensource.org/licenses/mit-license)**
