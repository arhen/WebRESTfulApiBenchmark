package models

//Classes is for class table on DB
type Classes struct {
	ClassesID   int32  `gorm:"primary_key;auto_increment" json:"id"`
	Title       string `gorm:"size:64;not_null" json:"title"`
	Description string `gorm:"type:text;not_null" json:"description"`
}
