# 📸 Telegram Silent Screenshot Sender 👩‍💻

[![Stars](https://img.shields.io/github/stars/ZeroEthical/Silent-Telegram-Screenshot-Sender?style=social)](https://github.com/ZeroEthical/Silent-Telegram-Screenshot-Sender/stargazers)
[![Forks](https://img.shields.io/github/forks/ZeroEthical/Silent-Telegram-Screenshot-Sender?style=social)](https://github.com/ZeroEthical/Silent-Telegram-Screenshot-Sender/network/members)
[![Issues](https://img.shields.io/github/issues/ZeroEthical/Silent-Telegram-Screenshot-Sender)](https://github.com/ZeroEthical/Silent-Telegram-Screenshot-Sender/issues)
[![License](https://img.shields.io/github/license/ZeroEthical/Silent-Telegram-Screenshot-Sender)](LICENSE)

Este programa en C# toma una captura de pantalla del escritorio y la envía silenciosamente a través de un bot de Telegram. ¡Perfecto para... bueno, para lo que sea! 😈

## 🧾 Prerrequisitos

Antes de empezar, asegúrate de tener lo siguiente:

*   ✅ **.NET SDK o Visual Studio con Símbolo del sistema para desarrolladores**
    *   [Descargar .NET SDK](https://dotnet.microsoft.com/download)
*   ✅ **Token de Bot de Telegram y Chat ID**

## 🔧 Compilación

1.  **Guarda el código:**
    *   Crea un archivo `Program.cs` y pega el código C#.
    *   **Importante:** Reemplaza `token` y `chatId` con tus credenciales reales.

    ```csharp
    string token = ""; // TU TOKEN DE BOT DE TELEGRAM
    string chatId = ""; // TU ID DE CHAT DE TELEGRAM
    ```

2.  **Abre CMD/PowerShell:**
    *   Navega al directorio donde guardaste `Program.cs`.

3.  **Compila con CSC:**

    ```bash
    "C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe" /target:exe /platform:x86 /optimize Program.cs
    ```

    *   O, en sistemas de 64 bits:

    ```bash
    "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /target:exe /platform:x64 /optimize Program.cs
    ```

    *   Esto creará `Program.exe` en la misma carpeta.

4.  **Ejecuta el programa:**

    ```bash
    Program.exe
    ```

    *   **Importante:** No se abrirá ninguna ventana ni se guardará ningún archivo. La captura de pantalla se envía silenciosamente a través de Telegram.

## 💎 Características del código fuente:

*   ✅ **Ejecución silenciosa:** Sin ventanas molestas.
*   🖼 **Funcionalidad de captura de pantalla:** Toma capturas de pantalla del escritorio.
*   🖼 **Subida a Telegram:** Envía la captura directamente a tu chat.
*   💾 **Sin archivos guardados localmente:** Sin dejar rastro.
*   🔄 **Retroceso de errores:** Oculta cualquier error para mantener la ejecución discreta.
*   🛠 **Llamadas Win32 integradas:** Usa funciones nativas para un acceso más profundo al sistema.

*   # Contribucion
* Si quieres contribuir, ¡adelante! Pero no me vengas con tonterías de "código ético" o "buenas prácticas". Aquí solo nos importa que funcione.😜
  

## ⚠️ Descargo de responsabilidad

Este código se proporciona únicamente con fines educativos. No me hago responsable de su uso indebido. ¡Utilízalo con responsabilidad! 😉

---

Hecho con 😈 por [ZeroEthical](https://t.me/ZeroEthical)
