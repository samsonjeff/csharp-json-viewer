# csharp-json-viewer

A sleek, lightweight C# Windows Forms application designed to fetch, read, and view JSON data tables easily. It supports extracting data directly from public online REST APIs or loading local `.json` files from your computer storage.

[![GitHub Repo](https://img.shields.io/badge/GitHub-Repository-blue?logo=github)](https://github.com/samsonjeff/csharp-json-viewer)
[![Language](https://img.shields.io/badge/Language-C%23-green)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-.NET%20Windows%20Forms-purple)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)

---

## Key Features

- **Dual-Mode Fetching**: Pull live data asynchronously from a web URL (`HttpClient`) or parse standard local files (`File.ReadAllTextAsync`).
- **Dynamic Grid Mapping**: Parses complex array models into a clean, searchable user presentation via `DataGridView`.
- **State-Driven Workflow**: Adaptive button validation prevents execution conflicts (buttons toggle automatically based on active choice).
- **One-Click Quick Fill**: Integrated `LinkLabel` mapping for instant API endpoint testing.

---

## Prerequisite Checklist

Before setting up or cloning the repository locally, ensure your personal machine has:
1. **Operating System**: Windows 10 or Windows 11 (Windows Forms requires native Win32 framework bindings).
2. **IDE**: [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (Community, Professional, or Enterprise editions).
3. **Workload**: During Visual Studio installation, make sure the **.NET Desktop Development** workload checkbox is fully ticked.

---

## Initial Project Setup

Follow these exact steps to load, compile, and run the program locally on your computer:

### 1. Clone the Source Code
Open your command terminal (Git Bash, PowerShell, or Command Prompt) and target your workspace folder:
```bash
git clone [https://github.com/samsonjeff/csharp-json-viewer.git](https://github.com/samsonjeff/csharp-json-viewer.git)
cd csharp-json-viewer

---
