-- SQLite dump for Smart Waste Management System
-- Run this to populate your database with sample data

-- Insert sample waste entries
INSERT INTO WasteEntries (HouseholdName, WasteType, WasteAmount, Date) VALUES
('Sabio Family', 'Food', 2.5, '2026-03-15'),
('Manalili Residence', 'Plastic', 1.2, '2026-03-16'),
('Gamao Household', 'Paper', 0.8, '2026-03-17'),
('Quilang Family', 'Food', 3.0, '2026-03-18'),
('Sabio Family', 'Plastic', 1.5, '2026-03-18'),
('Manalili Residence', 'Paper', 0.5, '2026-03-19'),
('Gamao Household', 'Food', 2.0, '2026-03-19'),
('Quilang Family', 'Plastic', 2.2, '2026-03-19'),
('Sabio Family', 'Paper', 0.7, '2026-03-20'),
('Manalili Residence', 'Food', 1.8, '2026-03-20');

-- Check inserted data
SELECT * FROM WasteEntries;
