resource "azurerm_app_service_plan" "myPlan" {
  name                = var.servicePlan
  location            = var.location
  resource_group_name = azurerm_resource_group.resource_Group_Name.name

  sku {
    tier = "Standard"
    size = "S1"
  }
}