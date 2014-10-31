module Danhmuc
  class DmnhomsController < PageController
    helper_method :sort_column, :sort_direction
    respond_to :html, :js

    def index
      @dmnhoms = Dmnhom.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    end

    def show
      @dmnhom = Dmnhom.find(params[:id])
    end

    def edit
      @dmnhom = Dmnhom.find(params[:id])
    end

    def update
      @dmnhoms = Dmnhom.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

      @dmnhom = Dmnhom.find(params[:id])
      @dmnhom.update_attributes(dmnhom_params)
    end

    def new
      @dmnhom = Dmnhom.new
    end

    def create
      @dmnhoms = Dmnhom.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmnhom =Dmnhom.create(dmnhom_params)
    end

    def delete
      @dmnhom = Dmnhom.find(params[:dmnhom_id])
    end

    def destroy
      @dmnhoms = Dmnhom.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmnhom = Dmnhom.find(params[:id])
      @dmnhom.destroy
    end

    private
    def dmnhom_params
      params.require(:dmnhom).permit(:stt, :ten, :dmnhombc_id, :dmnhomin_id)
    end

    def sort_column
      Dmnhom.column_names.include?(params[:sort]) ? params[:sort] : "ten"
    end

    def sort_direction
      %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
    end
  end
end