module Danhmuc
  class DmnhominsController < PageController


    respond_to :html, :js

    def index
      @dmnhomins = Dmnhomin.all
    end

    def show
      @dmnhomin = Dmnhomin.find(params[:id])
    end

    def edit
      @dmnhomin = Dmnhomin.find(params[:id])
    end

    def update
      @dmnhomins = Dmnhomin.all
      @dmnhomin = Dmnhomin.find(params[:id])

      @dmnhomin.update_attributes(dmnhomin_params)
    end

    def new
      @dmnhomin = Dmnhomin.new
    end

    def create
      @dmnhomins = Dmnhomin.all
      @dmnhomin = Dmnhomin.create(dmnhomin_params)
    end

    def delete
      @dmnhomin = Dmnhomin.find(params[:dmnhomin_id])
    end

    def destroy
      @dmnhomins = Dmnhomin.all
      @dmnhomin = Dmnhomin.find(params[:id])
      @dmnhomin.destroy
    end

    private
    def dmnhomin_params
      params.require(:dmnhomin).permit(:stt, :ten)
    end
  end
end