package models

import (
	"encoding/json"
	"time"

	"github.com/jinzhu/gorm"
)

// Students is data binding from students table mysql
type Students struct {
	StudentID int32     `gorm:"primary_key;auto_increment" json:"id"`
	Firstname string    `gorm:"size:16;not_null" json:"-"`
	Lastname  string    `gorm:"size:64;not_null" json:"-"`
	Birthdate time.Time `gorm:"default:CURRENT_TIMESTAMP"`
}

func (d *Students) MarshalJSON() ([]byte, error) {
	type Alias Students
	return json.Marshal(&struct {
		*Alias
		Birthdate string `json: "birtdate"`
		Fullname  string `json: "fullname"`
	}{
		Alias:     (*Alias)(d),
		Fullname:  d.Firstname + " " + d.Lastname,
		Birthdate: d.Birthdate.Format("Monday 02, January 2006 15:04 MST"),
	})
}

func (u *Students) FindAllStudents(db *gorm.DB) (*[]Students, error) {
	var err error
	students := []Students{}
	err = db.Model(&Students{}).Find(&students).Error
	if err != nil {
		return &[]Students{}, err
	}
	return &students, err
}
