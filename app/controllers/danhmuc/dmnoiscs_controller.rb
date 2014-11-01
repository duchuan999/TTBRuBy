module Danhmuc
  class DmnoiscsController < PageController
    respond_to :html, :js

    def index
      @dmnoiscs = Dmnoisc.all
    end

    def show
      @dmnoisc = Dmnoisc.find(params[:id])
    end

    def edit
      @dmnoisc = Dmnoisc.find(params[:id])
    end

    def update
      @dmnoiscs = Dmnoisc.all
      @dmnoisc = Dmnoisc.find(params[:id])

      @dmnoisc.update_attributes(dmnoisc_params)
    end

    def new
      @dmnoisc = Dmnoisc.new
    end

    def create
      @dmnoiscs = Dmnoisc.all
      @dmnoisc = Dmnoisc.create(dmnoisc_params)
    end

    def delete
      @dmnoisc = Dmnoisc.find(params[:dmnoisc_id])
    end

    def destroy
      @dmnoiscs = Dmnoisc.all
      @dmnoisc = Dmnoisc.find(params[:id])
      @dmnoisc.destroy
    end

    private
    def dmnoisc_params
      params.require(:dmnoisc).permit(:stt, :ma, :ten, :diachi)
    end
  end
end