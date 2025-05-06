using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Management_ni_gad
{
    internal class Scratch2
    {
    }

    /*
    CREATE DATABASE IF NOT EXISTS office_asset_manager;
USE office_asset_manager;

-- User Management
CREATE TABLE users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    full_name VARCHAR(100),
    role ENUM('Admin', 'Employee') NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Assets Table
CREATE TABLE assets (
    asset_id INT AUTO_INCREMENT PRIMARY KEY,
    asset_name VARCHAR(100) NOT NULL,
    category VARCHAR(50),
    purchase_date DATE,
    status ENUM('Available', 'Assigned', 'Under Maintenance', 'Retired') DEFAULT 'Available',
    value DECIMAL(10,2),
    notes TEXT
);

-- Asset Assignment Table
CREATE TABLE asset_assignments (
    assignment_id INT AUTO_INCREMENT PRIMARY KEY,
    asset_id INT NOT NULL,
    user_id INT NOT NULL,
    assigned_date DATE DEFAULT CURRENT_DATE,
    return_date DATE,
    status ENUM('Assigned', 'Returned') DEFAULT 'Assigned',
    FOREIGN KEY (asset_id) REFERENCES assets(asset_id),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

-- Maintenance Table
CREATE TABLE maintenance (
    maintenance_id INT AUTO_INCREMENT PRIMARY KEY,
    asset_id INT NOT NULL,
    issue_description TEXT,
    maintenance_date DATE DEFAULT CURRENT_DATE,
    maintenance_status ENUM('Pending', 'In Progress', 'Completed') DEFAULT 'Pending',
    cost DECIMAL(10,2),
    FOREIGN KEY (asset_id) REFERENCES assets(asset_id)
);
    */

}
