# Seminario de Lenguaje — .NET

## 🟣 Guía de instalación — .NET

### Requisitos previos

Antes de comenzar, verificá si ya tenés .NET instalado:

```bash
dotnet --version
```

Si el comando devuelve una versión, podés saltear la instalación.

---

### 📥 Instalación

Descargá el SDK desde la página oficial de Microsoft (se recomienda la última versión estable):

🔗 https://dotnet.microsoft.com/download/dotnet

---

### 🚀 Crear y ejecutar un proyecto

#### 1. (Opcional) Limpiar proyectos anteriores

> ⚠️ Solo hacer esto en las computadoras de la facultad para evitar conflictos con proyectos viejos.

```bash
rm -r proyectosDotnet
```

#### 2. Crear la carpeta del proyecto

```bash
mkdir proyectosDotnet
cd proyectosDotnet
```

#### 3. Crear la aplicación

```bash
dotnet new console -o nombreDeLaAplicacion
```

#### 4. Entrar al proyecto y ejecutarlo

```bash
cd nombreDeLaAplicacion
dotnet run
```

---

### 📁 Estructura generada

```
nombreDeLaAplicacion/
├── Program.cs          ← código principal
├── nombreDeLaAplicacion.csproj
└── obj/
```

---

### 💡 Comandos útiles

| Comando | Descripción |
|--------|-------------|
| `dotnet --version` | Ver versión instalada |
| `dotnet new console -o <nombre>` | Crear nueva app de consola |
| `dotnet run` | Compilar y ejecutar |
| `dotnet build` | Solo compilar |
