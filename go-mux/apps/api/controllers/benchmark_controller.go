package controllers

import (
	"net/http"

	"github.com/arhen/WebRESTfulApiBenchmark/go-mux/apps/api/models"
	"github.com/arhen/WebRESTfulApiBenchmark/go-mux/apps/api/responses"
)

func (server *Server) HelloWorld(w http.ResponseWriter, r *http.Request) {
	var res [2]string
	res[0] = "Hello"
	res[1] = "world"
	responses.JSON(w, http.StatusOK, res)
}

func (server *Server) SimpleListing(w http.ResponseWriter, r *http.Request) {
	student := models.Students{}

	students, err := student.FindAllStudents(server.DB)
	if err != nil {
		responses.ERROR(w, http.StatusBadRequest, err)
		return
	}

	responses.JSON(w, http.StatusOK, students)
}
