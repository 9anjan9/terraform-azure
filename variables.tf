variable "resourceGroupName" {
    type = string
}

variable "location" {
    type = string
}

variable "tags" {
    type = map(any)
}

variable "subnetname" {
    type = string
}

variable "vnetname" {
    type = string
}

variable "ipaddressname" {
    type = string
}

variable "nsgname" {
    type = string
}
