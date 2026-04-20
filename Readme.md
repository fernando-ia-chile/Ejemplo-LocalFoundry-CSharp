# Foundry Local y Agentes en Azure

## Instalación y uso básico de Foundry Local

Referencia: [Documentación oficial](https://learn.microsoft.com/es-es/azure/foundry-local/get-started)

### Comandos principales

```powershell
# Instalar Foundry Local
winget install Microsoft.FoundryLocal

# Verificar versión instalada
foundry --version

# Revisar estado del servicio
foundry service status

# Iniciar servicio
foundry service start

# Listar modelos disponibles
foundry model list

# Ejecutar un modelo (ejemplo con phi-4-mini)
foundry model run phi-4-mini "Hola mundo"

# Actualizar Foundry Local
winget upgrade Microsoft.FoundryLocal
```

## Modelos disponibles

- `phi-4-mini`

## Agentes

Referencia: [Azure AI Agents - Cloud Adoption Framework](https://learn.microsoft.com/es-mx/azure/cloud-adoption-framework/ai-agents/)

## Código C# — Librerías

| Librería | Descripción |
|---|---|
| `OpenAI` | Genera el cliente que interactúa con el modelo de IA |
| `Microsoft.Agents.AI` | Microsoft Agent Framework (incluir versiones preliminares) — capacidades de agentes |
| `Microsoft.Agents.AI.OpenAI` | Genera el agente a partir del cliente que interactúa con el modelo |

### Requisito previo

```powershell
# Instalar .NET SDK 9
winget install Microsoft.DotNet.SDK.9
```
