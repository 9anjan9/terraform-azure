resource "azurerm_resource_group" "myterraformGroup" {
    name = var.resourceGroupName
    location = var.location
    tags = var.tags
}
