resource "azurerm_resource_group" "myterraformGroup" {
    name = var.resouceGroupName
    location = var.location
    tags = var.tags
}