# Tailwind setup for Card-Tools-Web

This project includes Tailwind CSS source and build scripts. The generated CSS file is `wwwroot/css/app.css` and is already referenced from `wwwroot/index.html`.

Quick setup (Windows PowerShell):

1. Install Node.js (LTS) from https://nodejs.org/ if not already installed.
2. Open PowerShell and run:

```powershell
cd "D:/Project/C#/Card-Tools-Web/Card-Tools-Web";
npm install;
npm run build:css
```

- `npm install` will install `tailwindcss`, `postcss`, and `autoprefixer` as devDependencies.
- `npm run build:css` compiles `styles/tailwind.css` to `wwwroot/css/app.css`.

For development you can run:

```powershell
npm run watch:css
```

This watches source files and updates `wwwroot/css/app.css` automatically.

If `npx tailwindcss` fails, ensure Node.js/npm is installed and try `npx tailwindcss --version` to verify.

