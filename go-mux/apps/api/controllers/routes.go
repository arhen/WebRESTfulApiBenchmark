package controllers

import "github.com/arhen/WebRESTfulApiBenchmark/go-mux/apps/api/middlewares"

func (s *Server) initializeRoutes() {

	s.Router.HandleFunc("/api/benchmark/hello", middlewares.SetMiddlewareJSON(s.HelloWorld)).Methods("GET")

	s.Router.HandleFunc("/api/benchmark/simple-listing", middlewares.SetMiddlewareJSON(s.SimpleListing)).Methods("GET")

}
