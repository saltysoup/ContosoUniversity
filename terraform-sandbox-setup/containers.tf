/**
 * Copyright 2018 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

 
locals {
  zone1                    = "a"
  zone2                    = "b"
  num_instances_containers = 1
  machine_type_containers  = "e2-medium"
  disk_type_containers     = "pd-standard"
  disk_size_gb_containers  = 40
}


#####################
# Kubernetes cluster
#####################

resource "random_id" "container_randomchar" {
  byte_length = 2
}

module "gke" {
  source                     = "terraform-google-modules/kubernetes-engine/google"
  project_id                 = var.project_id
  name                       = "${var.name}-${random_id.container_randomchar.hex}"
  region                     = var.region
  zones                      = ["${var.region}-${local.zone1}","${var.region}-${local.zone2}"]
  network                    = var.network
  subnetwork                 = var.network_vpc_subnet1
  ip_range_pods              = var.network_vpc_subnet_gke_pods
  ip_range_services          = var.network_vpc_subnet_gke_services
  http_load_balancing        = false
  horizontal_pod_autoscaling = false
  network_policy             = false

  node_pools = [
    {
      name                      = "${var.name}-default-node-pool"
      machine_type              = local.machine_type_containers
      node_locations            = "${var.region}-${local.zone1},${var.region}-${local.zone2}"
      min_count                 = local.num_instances_containers
      max_count                 = local.num_instances_containers
      local_ssd_count           = 0
      disk_size_gb              = local.disk_size_gb_containers
      disk_type                 = local.disk_type_containers
      image_type                = "COS"
      auto_repair               = true
      auto_upgrade              = true
      preemptible               = false
    },
    {
      name                      = "${var.name}-windows-node-pool"
      machine_type              = local.machine_type_containers
      node_locations            = "${var.region}-${local.zone1},${var.region}-${local.zone2}"
      min_count                 = local.num_instances_containers
      max_count                 = local.num_instances_containers
      local_ssd_count           = 0
      disk_size_gb              = local.disk_size_gb_containers
      disk_type                 = local.disk_type_containers
      image_type                = "WINDOWS_LTSC",
      release_channel           = "regular"
      auto_repair               = true
      auto_upgrade              = false
      preemptible               = false
    },
  ]

  node_pools_labels = {
    all = {}

    default-node-pool = {
      default-node-pool = true
    }
  }

}