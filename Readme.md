\# Foundry Local y Agentes en Azure



\## 📌 Instalación y uso básico de Foundry Local

Referencia: \[Documentación oficial](https://learn.microsoft.com/es-es/azure/foundry-local/get-started)



\### Comandos principales

```powershell

\# Instalar Foundry Local

winget install Microsoft.FoundryLocal



\# Verificar versión instalada

foundry --version



\# Revisar estado del servicio

foundry service status



\# Iniciar servicio

foundry service start



\# Listar modelos disponibles

foundry model list



\# Ejecutar un modelo (ejemplo con phi-4-mini)

foundry model run phi-4-mini "Hola mundo"



\# Actualizar Foundry Local

winget upgrade Microsoft.FoundryLocal



