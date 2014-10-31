module Danhmuc
  class DmnguonsController < PageController

    respond_to :html, :js

    def index
      @dmnguons = Dmnguon.all
    end

    def show
      @dmnguon = Dmnguon.find(params[:id])
    end

    def edit
      @dmnguon = Dmnguon.find(params[:id])
    end

    def update
      @dmnguons = Dmnguon.all
      @dmnguon = Dmnguon.find(params[:id])

      @dmnguon.update_attributes(dmnguon_params)
    end

    def new
      @dmnguon = Dmnguon.new
    end

    def create
      @dmnguons = Dmnguon.all
      @dmnguon = Dmnguon.create(dmnguon_params)
    end

    def delete
      @dmnguon = Dmnguon.find(params[:dmnguon_id])
    end

    def destroy
      @dmnguons = Dmnguon.all
      @dmnguon = Dmnguon.find(params[:id])
      @dmnguon.destroy
    end

    private
    def dmnguon_params
      params.require(:dmnguon).permit(:stt, :ten)
    end
  end
end